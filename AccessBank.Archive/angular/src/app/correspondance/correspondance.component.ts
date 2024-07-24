import { ListService, PagedResultDto } from '@abp/ng.core';
import { ConfirmationService, Confirmation } from '@abp/ng.theme.shared';
import { query } from '@angular/animations';
import { Component, OnInit } from '@angular/core';
import { FormGroup,FormBuilder, Validators } from '@angular/forms';
import { CorrespondanceService, CorrespondanceDto, receiverOptions, receptionistOptions,approverOptions, statusOptions } from '@proxy/correspondances';


@Component({
  selector: 'app-correspondance',
  templateUrl: './correspondance.component.html',
  styleUrl: './correspondance.component.scss',
  providers:[ListService],
})
export class CorrespondanceComponent {
  correspondance = { items: [], totalCount:0 } as PagedResultDto<CorrespondanceDto>;
  selectedCorrespondance = {} as CorrespondanceDto;
  
  form: FormGroup;
  
  receiver = receiverOptions;
  receptionist = receptionistOptions;
  approver = approverOptions;
  status = statusOptions;

  
  isModalOpen = false;

  constructor(
    public readonly list: ListService, 
    private correspondanceService:CorrespondanceService,
    private fb: FormBuilder,
    private confirmation: ConfirmationService
  ){}

  ngOnInit()
  {
    const correspondanceStreamCreator = (query) => this.correspondanceService.getList(query);
    this.list.hookToQuery(correspondanceStreamCreator).subscribe((response) =>{
      this.correspondance= response;
    });
  }

  delete(id:string){
    this.confirmation.warn('::AreYouSureToDelete', '::AreYouSure').subscribe((status) =>{
      if(status === Confirmation.Status.confirm){
        this.correspondanceService.delete(id).subscribe(() =>this.list.get());
      }
    })
  }

  createCorrespondance()
  {
    this.selectedCorrespondance = {} as CorrespondanceDto;
    this.buildForm();
    this.isModalOpen = true;
  }

  editCorrespondance(id: string){
    this.correspondanceService.get(id).subscribe((correspondance) =>{
      this.selectedCorrespondance = correspondance;
      this.buildForm();
      this.isModalOpen = true;
    });
  }

  buildForm(){
    this.form = this.fb.group(
      {
      sender: [this.selectedCorrespondance.sender || '', Validators.required],
      receptionist: [this.selectedCorrespondance.cco || null, Validators.required],
      // receiver: ['', Validators.required],
      branchName: [this.selectedCorrespondance.branchName || '', Validators.required],
      approver: [this.selectedCorrespondance.correspondanceApprover || null, Validators.required],
      // status: [null, Validators.required],
      receiver:[this.selectedCorrespondance.destinator || null, Validators.required],
      reference: [this.selectedCorrespondance.reference || '', Validators.required],
  
      });
  }
  save()
  {
    if(this.form.invalid)
    {
      return;
    }
    const request = this.selectedCorrespondance.id
    ? this.correspondanceService.update(this.selectedCorrespondance.id, this.form.value)
    : this.correspondanceService.create(this.form.value);

    request.subscribe(()=>{
      this.isModalOpen = false;
      this.form.reset();
      this.list.get();
    })
  }
}
