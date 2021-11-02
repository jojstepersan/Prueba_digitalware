import { Component, OnInit } from '@angular/core'
import { ProductoService } from 'src/services/productos.service'
import { ApiResponse } from 'src/config/reponse.config'
import { Bodega } from 'src/app/Models/Bodega'

@Component({
  templateUrl: 'stocks.component.html'
})
export class StocksComponent implements OnInit {
  dataSource: Array<Bodega>

  constructor(private producto: ProductoService) {}

  ngOnInit() {

    this.onLoadProductos();
  }

  onInsertRow(e) {

    const model = [e.data]
    this.producto
    .post(model).subscribe(
      (response: any) => {
        console.log(response.data)
      },
      (err: any) => {

        console.log(err)
      },
      () => {
        this.onLoadProductos();
      }
    )
  }

  onLoadProductos() {

    this.producto
      .getAll()
      .subscribe((response: any) => (this.dataSource = response.data))
  }
}
