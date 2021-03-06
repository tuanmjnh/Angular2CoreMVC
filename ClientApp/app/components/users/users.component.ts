import { Component, ViewChild, ViewContainerRef, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators, ReactiveFormsModule, FormsModule } from '@angular/forms';
import { ActivatedRoute, Router, CanDeactivate } from '@angular/router'
import { Http } from '@angular/http';
import { ModalDirective } from 'ngx-bootstrap/modal'
import { Users } from "../models/users";
import { modalActionComponent } from "../common/modalAction.component";
import { Hero } from '../shared/hero';

@Component({
    selector: 'users',
    //directives: [modalCreateComponent],
    templateUrl: './users.component.html'
})
export class UsersComponent{
    powers = ['Really Smart', 'Super Flexible', 'Weather Changer'];
    //hero = new Hero(18, 'Dr. WhatIsHisWayTooLongName', this.powers[0], 'Dr. What');
    user = new Users(null, '', '', '', '', '', '', '', '', 0, '', new Date(), '', new Date(), new Date(), '', 1, '', false);
    public submitted: boolean;
    public events: any[] = [];
    public id: Number;
    public title: string;
    public users: Users[];
    //Modal
    //@ViewChild('childModal') childModal: modalActionComponent;
    constructor(
        private viewContainerRef: ViewContainerRef,
        private http: Http,
        public fb: FormBuilder) { // private dialogService: DialogService
        this.getData();
        
        //this.UserForm = fb.group({
        //    'username': [null, Validators.compose([Validators.required, Validators.minLength(6), Validators.maxLength(50)])],
        //});
    }
    getData() {
        this.http.get('/api/Users/Get').subscribe(result => {
            this.users = result.json() as Users[];
            this.users.forEach(x => x.state = false);
        });
    }
    //
    onSubmit() {
        this.submitted = true;
        console.log(this.user);
    }
    active = true;

    addHero() {
        //this.hero = new Hero(42, '', '');

        this.active = false;
        setTimeout(() => this.active = true, 0);
    }
    //CheckBox
    checkAll(ev) {
        this.users.forEach(x => x.state = ev.target.checked)
    }
    isAllChecked() {
        return this.users.every(_ => _.state);
    }
}
//interface Users {
//    id: string;
//    username: string;
//    password: string;
//    salt: string;
//    fullName: string;
//    mobile: string;
//    email: string;
//    address: string;
//    roles: string;
//    orders: number;
//    createdBy: string;
//    createdAt: Date;
//    updatedBy: string;
//    updatedAt: Date;
//    lastLogin: Date;
//    staffId: string;
//    flag: number;
//    extras: string;
//    state: boolean;
//}