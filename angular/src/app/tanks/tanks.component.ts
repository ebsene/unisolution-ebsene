import { Component, Injector } from '@angular/core';
import { finalize } from 'rxjs/operators';
import { BsModalService, BsModalRef } from 'ngx-bootstrap/modal';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import {
  PagedListingComponentBase,
  PagedRequestDto,
} from '@shared/paged-listing-component-base';
import { TankDto } from '@shared/service-proxies/dto/tanks/tank-dto';
import { TankServiceProxy } from '@shared/service-proxies/service-proxies';
import { TankDtoPagedResultDto } from '@shared/service-proxies/dto/tanks/tank-dto-paged-result-dto';
import { CreateTankDialogComponent } from './create-tank/create-tank-dialog.component';
import { EditTankDialogComponent } from './edit-tank/edit-tank-dialog.component';

class PagedTanksRequestDto extends PagedRequestDto {
  keyword: string;
  isActive: boolean | null;
}

@Component({
  templateUrl: './tanks.component.html',
  animations: [appModuleAnimation()]
})
export class TanksComponent extends PagedListingComponentBase<TankDto> {
  tanks: TankDto[] = [];
  keyword = '';
  isActive: boolean | null;
  advancedFiltersVisible = false;

  constructor(
    injector: Injector,
    private _modalService: BsModalService,
    private _tankService: TankServiceProxy
  ) {
    super(injector);
  }

  list(
    request: PagedTanksRequestDto,
    pageNumber: number,
    finishedCallback: Function
  ): void {
    request.keyword = this.keyword;
    request.isActive = this.isActive;

    this._tankService
      .getAll(
        request.keyword,
        request.isActive,
        request.skipCount,
        request.maxResultCount
      )
      .pipe(
        finalize(() => {
          finishedCallback();
        })
      )
      .subscribe((result: TankDtoPagedResultDto) => {
        this.tanks = result.items;
        this.showPaging(result, pageNumber);
      });
  }

  clearFilters(): void {
    this.keyword = '';
    this.isActive = undefined;
    this.getDataPage(1);
  }

  createTank(): void {
    this.showCreateOrEditTankDialog();
  }

  editTank(tank: TankDto): void {
    this.showCreateOrEditTankDialog(tank.id);
  }

  showCreateOrEditTankDialog(id?: string): void {
    let createOrEditTankDialog: BsModalRef;
    if (!id || id === '') {
      createOrEditTankDialog = this._modalService.show(
        CreateTankDialogComponent,
        {
          class: 'modal-lg'
        }
      );
    } else {
      createOrEditTankDialog = this._modalService.show(
        EditTankDialogComponent,
        {
          class: 'modal-lg',
          initialState: {
            id: id
          }
        }
      );
    }

    createOrEditTankDialog.content.onSave.subscribe(() => {
      this.refresh();
    });
  }

  delete(tank: TankDto): void {
    abp.message.confirm(
      this.l('TankDeleteWarningMessage', tank.id),
      undefined,
      (result: boolean) => {
        if (result) {
          this._tankService
            .delete(tank.id)
            .pipe(
              finalize(() => {
                abp.notify.success(this.l('SuccessfullyDeleted'));
                this.refresh();
              })
            )
            .subscribe(() => {});
        }
      }
    );
  }
}
