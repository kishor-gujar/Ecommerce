import { Injectable } from "@angular/core";
import { Http, Response } from "@angular/http"
import "rxjs/Rx";

@Injectable()
export class UserService {
    constructor(private http: Http) { }

    getUsers() {
        return this.http.get("/api/users")
            .map(
            (response: Response) => {
                return response.json().items;
            });
    }
}