import { NgModule } from "@angular/core";
import { FormsModule } from '@angular/forms';

import { RouterModule } from "@angular/router";
import { UniversalModule } from "angular2-universal";
import { AppComponent } from "./components/app/app.component"
import { NavMenuComponent } from "./components/navmenu/navmenu.component";
import { HomeComponent } from "./components/home/home.component";
import { UsersComponent } from "./components/users/users.component";
import { ProdcutsComponent } from "./components/products/products.component";
import { ProdcutComponent } from "./components/product/product.component";
import { NewProdcutComponent } from "./components/new-product/new-product.component";
import { UserService } from "./services/user.service";
import { ProductService } from "./services/product.service";

@NgModule({
    bootstrap: [ AppComponent ],
    declarations: [
        AppComponent,
        NavMenuComponent,
        HomeComponent,
        UsersComponent,
        ProdcutsComponent,
        ProdcutComponent,
        NewProdcutComponent
    ],
    imports: [
        UniversalModule,
        FormsModule,
        // Must be first import. This automatically imports BrowserModule, HttpModule, and JsonpModule too.
        RouterModule.forRoot([
            { path: "", redirectTo: "home", pathMatch: "full" },
            { path: "home", component: HomeComponent },
            { path: "users", component: UsersComponent },
            { path: "product", component: ProdcutComponent },
            { path: "products", component: ProdcutsComponent },
            { path: "new-product", component: NewProdcutComponent },
            { path: "**", redirectTo: "home" }
        ])
    ],
    providers: [UserService,ProductService]
})
export class AppModule { }
