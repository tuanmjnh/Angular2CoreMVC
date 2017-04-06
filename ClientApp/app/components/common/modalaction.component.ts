import { Component, Input, ViewChild } from '@angular/core';
import { Http } from '@angular/http';
import { Router } from '@angular/router';
import { ModalDirective } from 'ngx-bootstrap/modal';
@Component({
    selector: 'modal-action',
    templateUrl: './modalAction.component.html',
})
export class modalActionComponent {
    @ViewChild('childModal') public childModal: ModalDirective;
    @Input() title?: string;
    @Input() btnAction?: string;
    @Input() btnCancel?: string;
    constructor() {
    }
    show() {
        this.childModal.show();
    }
    hide() {
        this.childModal.hide();
    }
    //private router: Router;
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