import { Injectable } from "@angular/core";
import { Http, Response, Headers } from "@angular/http";
import "rxjs/Rx";

@Injectable()
export class ProductService {
    constructor(private http: Http) { }

    getProducts() {
        return this.http.get("/api/products")
            .map(
                (response: Response) => {
                    return response.json().items;
                });
    }

    postProduct(content: string) {
        const body = JSON.stringify({ content: content });
        const headers = new Headers({ 'Content-Type': 'application/json' });
        return this.http.post("/api/products", body, { headers: headers });
    }
}
