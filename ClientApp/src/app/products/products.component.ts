import { Component,OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ProductsService } from '../services/products.service';
import { Products } from '../models/products.model';


@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit{

  products : Products[] = [];

  constructor(private productService: ProductsService) { }

  ngOnInit() : void {
    this.productService.getAllProducts().subscribe({
      next: (products) => {
        this.products = products;
        console.log(products);
      },
      error:(response) => {
        console.log('ERRRRROOR');
        console.log(response);

      }
    });
  }
}

