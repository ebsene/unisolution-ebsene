import {
    Component,
    Injector,
    OnInit,
    Output,
    EventEmitter
  } from '@angular/core';
  import { finalize } from 'rxjs/operators';
  import { BsModalRef } from 'ngx-bootstrap/modal';
  import { AppComponentBase } from '@shared/app-component-base';
import { CreateTankDto } from '@shared/service-proxies/dto/tanks/create-tank-dto';
import { TankServiceProxy } from '@shared/service-proxies/service-proxies';

  @Component({
    templateUrl: 'create-tank-dialog.component.html'
  })
  export class CreateTankDialogComponent extends AppComponentBase
    implements OnInit {
    saving = false;
    tank: CreateTankDto = new CreateTankDto();

    @Output() onSave = new EventEmitter<any>();

    constructor(
      injector: Injector,
      public bsModalRef: BsModalRef,
      public _tankService: TankServiceProxy
    ) {
      super(injector);
    }

    ngOnInit(): void {
    }

    save(): void {
      this.saving = true;

      this._tankService
        .create(this.tank)
        .pipe(
          finalize(() => {
            this.saving = false;
          })
        )
        .subscribe(() => {
          this.notify.info(this.l('SavedSuccessfully'));
          this.bsModalRef.hide();
          this.onSave.emit();
        });
    }
  }
