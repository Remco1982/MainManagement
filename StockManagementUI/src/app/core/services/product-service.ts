import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { CreateProductModel } from '../dataContracts/CreateProductModel'
import { ProductViewModel } from "../dataContracts/ProductViewModel";
import { Observable } from "rxjs";

@Injectable({
  providedIn: 'root'
})
export class ProductService {
  delete(productId: number) {
    throw new Error('Method not implemented.');
  }
  private url: string = 'https://localhost:7001/api';
  constructor(private http: HttpClient) { }

  public create(productToCreate: CreateProductModel) {
    return this.http.post<ProductViewModel>(`${this.url}/product`, productToCreate);
  }

  public getAll(): Observable<ProductViewModel[]> {
    return this.http.get<ProductViewModel[]>(`${this.url}/product`);
  }
}
