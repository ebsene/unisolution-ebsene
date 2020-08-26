import { TankDto } from "./tank-dto";

export interface ITankDtoPagedResultDto {
    totalCount: number;
    items: TankDto[] | undefined;
}

export class TankDtoPagedResultDto implements ITankDtoPagedResultDto {
    totalCount: number;
    items: TankDto[] | undefined;

    constructor(data?: ITankDtoPagedResultDto) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(data?: any) {
        if (data) {
            this.totalCount = data["totalCount"];
            if (Array.isArray(data["items"])) {
                this.items = [] as any;
                for (let item of data["items"])
                    this.items.push(TankDto.fromJS(item));
            }
        }
    }

    static fromJS(data: any): TankDtoPagedResultDto {
        data = typeof data === 'object' ? data : {};
        let result = new TankDtoPagedResultDto();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["totalCount"] = this.totalCount;
        if (Array.isArray(this.items)) {
            data["items"] = [];
            for (let item of this.items)
                data["items"].push(item.toJSON());
        }
        return data; 
    }

    clone(): TankDtoPagedResultDto {
        const json = this.toJSON();
        let result = new TankDtoPagedResultDto();
        result.init(json);
        return result;
    }
}