import { Component, OnInit } from '@angular/core';
import { Response } from "@angular/http"

import { ProductService } from "../../services/product.service";

@Component({
    selector: 'app-products',
    templateUrl: './products.component.html',
    providers: [ProductService]
})
export class ProdcutsComponent implements OnInit {
    products = [];

    constructor(private productService: ProductService) { }

    ngOnInit() {
        this.productService.getProducts()
            .subscribe(
                (products) => this.products = products,
                (error: Response) => console.log(error)
            );
    }

}
