import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';
import { FormsModule } from '@angular/forms';
import { UniversalModule } from 'angular2-universal';
import { AppComponent } from './components/app/app.component'
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';
import { FetchDataComponent } from './components/fetchdata/fetchdata.component';
import { CounterComponent } from './components/counter/counter.component';
//Extentions
import { BootstrapModalModule } from 'ng2-bootstrap-modal';
//Users
import { UsersComponent } from './components/users/users.component';
//import { usersModalCreateComponent } from './components/users/usersModalCreate.component';
//Modal
import { ConfirmComponent } from './components/modal/confirm.component';
import { TestModalComponent } from './components/modal/testmodal.component';

@NgModule({
    bootstrap: [AppComponent],
    declarations: [
        AppComponent,
        NavMenuComponent,
        CounterComponent,
        FetchDataComponent,
        HomeComponent,
        //Users
        UsersComponent,
        //usersModalCreateComponent
        ConfirmComponent,
        TestModalComponent
    ],
    imports: [
        UniversalModule, // Must be first import. This automatically imports BrowserModule, HttpModule, and JsonpModule too.
        FormsModule,
        BootstrapModalModule,
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            { path: 'counter', component: CounterComponent },
            { path: 'fetch-data', component: FetchDataComponent },
            //Users
            { path: 'users', component: UsersComponent },
            //Test
            { path: 'TestModal', component: TestModalComponent },
            //
            { path: '**', redirectTo: 'home' }
        ])
    ],
    //Don't forget to add the component to entryComponents section
    entryComponents: [
        ConfirmComponent
    ]
})
export class AppModule {
}
