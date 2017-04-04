import { Component, OnInit, ViewChild } from '@angular/core';
import { Http } from '@angular/http';
//import { ModalComponent } from 'ng2-bs3-modal/ng2-bs3-modal';
import { Router } from '@angular/router';
@Component({
    selector: 'app-modal',
    //directives: [MODAL_DIRECTIVES],
    templateUrl: './usersModalCreate.component.html'
})
export class usersModalCreateComponent {
    private router: Router;
    output: string;
    public open() { console.log('ff'); }
    //constructor(http: Http) {
    //}
    //Modal
    //@ViewChild(ModalComponent)
    //modal: ModalComponent;
    //public close() { this.modal.close(); }
    //public open() { this.modal.open(); }
    //public dismissed() { this.output = '(dismissed)'; }
    //public opened() { this.output = '(opened)'; }
    //public navigate() { this.router.navigateByUrl('/hello'); }
}