import { ListService, PagedResultDto } from '@abp/ng.core';
import { Component, OnInit } from '@angular/core';
import { CustomerService, CustomerDto } from '@proxy/customers';


@Component({
  selector: 'app-customer',
  templateUrl: './customer.component.html',
  styleUrl: './customer.component.scss',
  providers: [ListService],
})
export class CustomerComponent implements OnInit {
  customer = { items: [], totalCount: 0} as PagedResultDto<CustomerDto>;

  isModalOpen = false;
  
  constructor(public readonly list: ListService, private customerService: CustomerService){}
  
  ngOnInit() {
      
      const customerStreamCreator = (query) => this.customerService.getList(query);
      this.list.hookToQuery(customerStreamCreator).subscribe((response)=>{
        this.customer = response;
      });
  }

  createBook(){
    this.isModalOpen = true;
  }
}
