import { Injectable } from '@angular/core'
import { HttpClient } from '@angular/common/http'

import { Observable, throwError } from 'rxjs'
import { catchError, retry } from 'rxjs/operators'
import api from '../config/app.config'
import { ApiResponse } from 'src/config/reponse.config'
import { Bodega } from 'src/app/Models/Bodega'

@Injectable()
export class ProductoService {
  constructor(private http: HttpClient) {}

  getAll() {
    return this.http
      .get<ApiResponse>(api.invoice.actions.productos())
  }

  post(model: Array<Bodega>){
    return this.http
    .post<ApiResponse>(api.invoice.actions.productos(),model)
  }
}
