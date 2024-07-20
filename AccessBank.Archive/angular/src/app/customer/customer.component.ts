import { ListService, PagedResultDto } from '@abp/ng.core';
import { Component, OnInit } from '@angular/core';
import { CustomerService, CustomerDto, accountCategoryOptions, accountTypeOptions } from '@proxy/customers';
import { FormGroup, FormBuilder, Validators} from '@angular/forms';
import { NgbDateNativeAdapter, NgbDateAdapter} from '@ng-bootstrap/ng-bootstrap';
import { ConfirmationService, Confirmation } from '@abp/ng.theme.shared';

@Component({
  selector: 'app-customer',
  templateUrl: './customer.component.html',
  styleUrl: './customer.component.scss',
  providers: [
    ListService,
  {provide: NgbDateAdapter, useClass: NgbDateNativeAdapter}],
})
export class CustomerComponent implements OnInit {
  customer = { items: [], totalCount: 0} as PagedResultDto<CustomerDto>;
  selectedCustomer = {} as CustomerDto; //declare selectedCustomer

  form: FormGroup;
  accountTypes = accountTypeOptions;
  accountCategories = accountCategoryOptions;

  isModalOpen = false;
  
  constructor(
    public readonly list: ListService, 
    private customerService: CustomerService,
    private fb: FormBuilder,
    private confirmation: ConfirmationService
  ){}
  
  ngOnInit() {
      
      const customerStreamCreator = (query) => this.customerService.getList(query);
      this.list.hookToQuery(customerStreamCreator).subscribe((response)=>{
        this.customer = response;
      });
  }

  createCustomer(){
    this.selectedCustomer = {} as CustomerDto; // reset the selected Customer
    this.buildFrom();
    this.isModalOpen = true;
  }

  editCustomer(id: string)
  {
    this.customerService.get(id).subscribe((customer)=>{
      this.selectedCustomer = customer;
      this.buildFrom();
      this.isModalOpen = true;
    });
  }

  delete(id: string)
  {
    this.confirmation.warn('::AreYouSureToDelete', '::AreYouSure').subscribe((status) =>{
      if(status === Confirmation.Status.confirm){
        this.customerService.delete(id).subscribe(()=> this.list.get());
      }
    });
  }

  buildFrom(){
    this.form = this.fb.group({
      accountName: ['', Validators.required],
      accountNumber: ['', Validators.required],
      branchName: ['', Validators.required],
      branchCode: ['', Validators.required],
      type: [null, Validators.required],
      category: [null, Validators.required],
      onBoardDate:[null, Validators.required],
      accountStatus: [null, Validators.required],
      
    });
  }

  save(){
    if(this.form.invalid)
    {
      return;
    }
    const request = this.selectedCustomer.id//if the selected customer exists
    ?this.customerService.update(this.selectedCustomer.id, this.form.value)//update the information
    :this.customerService.create(this.form.value);//else create a new customer


    request.subscribe(() =>{
      this.isModalOpen = false;
      this.form.reset();
      this.list.get();
    });
  }
}
