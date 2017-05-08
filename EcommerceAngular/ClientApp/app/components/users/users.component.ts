import { Component, OnInit } from '@angular/core';
import { Response } from "@angular/http"

import { UserService } from "../../services/user.service";

@Component({
    selector: 'app-users',
    templateUrl: './users.component.html',
    providers: [UserService]
})
export class UsersComponent implements OnInit {
    users = [];

    constructor(private userService: UserService) { }

    ngOnInit() {
        this.userService.getUsers()
            .subscribe(
                (users) => this.users = users,
                (error: Response) => console.log(error)
            );
    }

}
