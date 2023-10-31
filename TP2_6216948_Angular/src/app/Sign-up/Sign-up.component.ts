import { Component, OnInit } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http'; // Import HttpClient for making HTTP requests
import { User } from 'src/Models/User';

@Component({
  selector: 'app-signup',
  templateUrl: './sign-up.component.html',
  styleUrls: ['./sign-up.component.css']
})
export class SignupComponent implements OnInit {
  registerActive: boolean = false;
  user: User = new User(0, '', '', '', '');
  username: string = '';
  email: string = '';
  password: string = '';
  passwordConfirm: string = '';

  estconnecte:boolean=false;
  loginActive: boolean = false;

  constructor(private http: HttpClient) {} // Inject HttpClient into the component
  ngOnInit(): void {
   
  }

  public changeRegisterOnClick(): void {
    this.registerActive = !this.registerActive;
  }

  public changeLoginOnClick(): void {
    this.loginActive = !this.loginActive;
  }

  async onSubmitRegister() {

    const user = new User(0, this.username, this.email, this.password, this.passwordConfirm);

    const registrationData = {
      username: user.username,
      email: user.email,
      password: user.password,
      passwordConfirm: user.passwordConfirm


    };

    this.http.post('http://localhost:7161/api/Users/Register', registrationData)
      .subscribe(
        response => {
          console.log('Registration successful:', response);

          
        },
        error => {
          console.error('Registration failed:', error);
        }
      );

      this.registerActive=false;
      this.username='';
      this.password="";
      this.email="";
      this.passwordConfirm="";

  }



  onSubmitLogin(username: string, password: string) {
    const user = {
      username: this.username,
      password: this.password
    };

    // Make a POST request to the login endpoint
    this.http.post<any>('http://localhost:7161/api/Users/Login', user ).subscribe(
      (response) => {
        // Handle the successful login response here
        console.log('Login successful:', response);
        const token = response.token;
        console.log(token);
        sessionStorage.setItem("authToken",token);
        this.estconnecte=true;
      },
      (error) => {
        // Handle login error here
        console.error('Login failed:', error);
      }
    );

    this.loginActive=false;
    
  }



  SeDeconnecter(){
    sessionStorage.removeItem("authToken");
    this.estconnecte=false;
  }

}