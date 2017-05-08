import { Component, OnInit } from '@angular/core';
import { NgForm } from "@angular/forms"
import { Response } from "@angular/http"

import { ProductService } from "../../services/product.service";

@Component({
    selector: "app-new-product",
    templateUrl: "./new-product.component.html",
    providers: [ProductService]
})
export class NewProdcutComponent implements OnInit {
    constructor(private productService: ProductService) { }

    ngOnInit() {
    }

    onSubmit(form: NgForm) {
        this.productService.postProduct(form.value.content)
            .subscribe(
                () => alert("Product Created Sucssesfully")
            );
        form.reset();
    }
}
