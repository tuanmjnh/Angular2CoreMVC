import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';
import { FormsModule } from '@angular/forms';
import { UniversalModule } from 'angular2-universal';
//import { CookieService } from 'angular2-cookie/services/cookies.service';
import { AppComponent } from './components/app/app.component'
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';
import { FetchDataComponent } from './components/fetchdata/fetchdata.component';
import { CounterComponent } from './components/counter/counter.component';
//Extentions
import { ModalModule } from 'ngx-bootstrap';
//import { BootstrapModalModule } from 'ng2-bootstrap-modal';
//Users
import { UsersComponent } from './components/users/users.component';
import { modalActionComponent } from './components/common/modalAction.component';
import { ProfileComponent } from './components/profile/profile.component';
import { HeroFormTemplateModule } from './components/template/hero-form-template.module';
import { HeroFormReactiveModule } from './components/reactive/hero-form-reactive.module';

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
        modalActionComponent,
        ProfileComponent
    ],
    imports: [
        UniversalModule, // Must be first import. This automatically imports BrowserModule, HttpModule, and JsonpModule too.
        //CookieService,
        FormsModule,
        //ReactiveFormsModule,
        HeroFormReactiveModule,
        HeroFormTemplateModule,
        ModalModule.forRoot(),
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            { path: 'counter', component: CounterComponent },
            { path: 'fetch-data', component: FetchDataComponent },
            //Users
            { path: 'users', component: UsersComponent },
            //Test
            { path: 'profile', component: ProfileComponent },
            //
            { path: '**', redirectTo: 'home' }
        ])
    ]
})
export class AppModule {
}
