export class Users {
    constructor(
        public id: string,
        public username: string,
        public password: string,
        public salt: string,
        public fullName: string,
        public mobile: string,
        public email: string,
        public address: string,
        public roles: string,
        public orders: number,
        public createdBy: string,
        public createdAt: Date,
        public updatedBy: string,
        public updatedAt: Date,
        public lastLogin: Date,
        public staffId: string,
        public flag: number,
        public extras: string,
        public state: boolean,
    ) { }
}