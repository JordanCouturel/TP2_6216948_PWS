import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor
} from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable()
export class AuthInterceptorInterceptor implements HttpInterceptor {

  constructor() {}

  intercept(request: HttpRequest<unknown>, next: HttpHandler): Observable<HttpEvent<unknown>> {
    if(request.url.startsWith('http://localhost:7161') &&  request.url != 'http://localhost:7161/api/Users/Register'){
      request = request.clone ({
        setHeaders: {
          'Content-Type' : 'application/json',
          'Authorization' : 'Bearer ' + sessionStorage.getItem("authToken")
        }
      });
    }

    console.log("MON INTERCEPTOR :", request, sessionStorage.getItem("authToken"));
    return next.handle(request);
  }


  


}
