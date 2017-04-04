import { Component, ViewChild, OnInit } from '@angular/core';
import { Http } from '@angular/http';
import { Router } from '@angular/router';
import { ConfirmComponent } from '../modal/confirm.component';
import { DialogService } from "ng2-bootstrap-modal";

@Component({
    selector: 'users',
    //directives: [modalCreateComponent],
    templateUrl: './users.component.html',
    //encapsulation: ViewEncapsulation.None
})
export class UsersComponent {
    public users: Users[];

    constructor(http: Http, private dialogService: DialogService) {
        http.get('/api/Users/Get').subscribe(result => {
            this.users = result.json() as Users[];
            this.users.forEach(x => x.state = false);
        });
    }
    //Modal
    showConfirm() {
        let disposable = this.dialogService.addDialog(ConfirmComponent, {
            title: 'Confirm title',
            message: 'Confirm message'
        })
            .subscribe((isConfirmed) => {
                //We get dialog result
                if (isConfirmed) {
                    alert('accepted');
                }
                else {
                    alert('declined');
                }
            });
        //We can close dialog calling disposable.unsubscribe();
        //If dialog was not closed manually close it by timeout
        //setTimeout(() => {
        //    disposable.unsubscribe();
        //}, 10000);
    }
    //CheckBox
    checkAll(ev) {
        this.users.forEach(x => x.state = ev.target.checked)
    }
    isAllChecked() {
        return this.users.every(_ => _.state);
    }
    //checkAll(ev) {
    //    this.sizes.forEach(x => x.state = ev.target.checked)
    //    console.log(sizes.state)
    //}

    //isAllChecked() {
    //    console.log('fired');
    //    return this.sizes.every(_ => _.state);
    //}
}
interface Users {
    id: string;
    username: string;
    password: string;
    salt: string;
    fullName: string;
    mobile: string;
    email: string;
    address: string;
    roles: string;
    orders: number;
    createdBy: string;
    createdAt: Date;
    updatedBy: string;
    updatedAt: Date;
    lastLogin: Date;
    staffId: string;
    flag: number;
    extras: string;
    state: boolean;
}