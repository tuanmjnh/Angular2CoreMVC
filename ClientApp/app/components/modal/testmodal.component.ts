import { Component } from '@angular/core';
import { ConfirmComponent } from './confirm.component';
import { DialogService } from "ng2-bootstrap-modal";

@Component({
    selector: 'testmodal',
    templateUrl: './testmodal.component.html'
})
export class TestModalComponent {
    constructor(private dialogService: DialogService) { }
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
        setTimeout(() => {
            disposable.unsubscribe();
        }, 10000);
    }
}