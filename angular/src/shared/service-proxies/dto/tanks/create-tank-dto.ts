export interface ICreateTankDto {
    id: string;
    capacity: number;
    productType: string;
}

export class CreateTankDto implements ICreateTankDto {
    id: string;
    capacity: number;
    productType: string;

    constructor(data?: ICreateTankDto) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(data?: any) {
        if (data) {
            this.id = data["id"];
            this.capacity = data["capacity"];
            this.productType = data["productType"];
        }
    }

    static fromJS(data: any): CreateTankDto {
        data = typeof data === "object" ? data : {};
        let result = new CreateTankDto();
        result.init(data);

        return result;
    }

    toJSON(data?: any) {
        data = typeof data === "object" ? data : {};
        data["id"] = this.id;
        data["capacity"] = this.capacity;
        data["productType"] = this.productType;
        
        return data;
    }
}