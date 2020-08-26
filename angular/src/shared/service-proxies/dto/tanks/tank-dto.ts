export interface ITankDto {
    id: string;
    capacity: number;
    productType: string;
}

export class TankDto implements ITankDto {
    id: string;
    capacity: number;
    productType: string;

    constructor(data?: ITankDto) {
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

    static fromJS(data: any): TankDto {
        data = typeof data === "object" ? data : {};
        let result = new TankDto();
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