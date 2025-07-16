import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { ProductService } from '../../../core/services/product-service';
import { ProductViewModel } from '../../../core/dataContracts/ProductViewModel';

@Component({
  selector: 'app-products',
  // Remove imports from @Component, use providers if needed
  providers: [ProductService],
  templateUrl: './product-create.component.html',
  styleUrls: ['./product-create.component.scss']
})
export class ProductComponent implements OnInit {
  public products: ProductViewModel[] = [];
  
  constructor(private _productService: ProductService) { }

  public ngOnInit(): void {
    this.getProducts();
  }

  public getProducts(): void {
    this._productService.getAll().subscribe({
      next: (receivedProducts) => {
        this.products = receivedProducts;
      },
      error: (err) => {
        console.error('Error fetching products:', err);
      }
    });
  }

  public deleteProduct(productId: number): void {
    this._productService.delete(productId).subscribe({
      next: (): void => {
        this.products = this.products.filter((product: ProductViewModel) => product.id !== productId);
      },
      error: (err: any): void => {
        console.error('Error deleting product:', err);
      }
    });
  }
}