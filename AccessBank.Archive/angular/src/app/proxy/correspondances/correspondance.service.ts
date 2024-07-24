import type { CorrespondanceDto, CreateUpadteCorrespondanceDto } from './models';
import { RestService, Rest } from '@abp/ng.core';
import type { PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class CorrespondanceService {
  apiName = 'Default';
  

  create = (input: CreateUpadteCorrespondanceDto, config?: Partial<Rest.Config>) =>
    this.restService.request<any, CorrespondanceDto>({
      method: 'POST',
      url: '/api/app/correspondance',
      body: input,
    },
    { apiName: this.apiName,...config });
  

  delete = (id: string, config?: Partial<Rest.Config>) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/correspondance/${id}`,
    },
    { apiName: this.apiName,...config });
  

  get = (id: string, config?: Partial<Rest.Config>) =>
    this.restService.request<any, CorrespondanceDto>({
      method: 'GET',
      url: `/api/app/correspondance/${id}`,
    },
    { apiName: this.apiName,...config });
  

  getList = (input: PagedAndSortedResultRequestDto, config?: Partial<Rest.Config>) =>
    this.restService.request<any, PagedResultDto<CorrespondanceDto>>({
      method: 'GET',
      url: '/api/app/correspondance',
      params: { sorting: input.sorting, skipCount: input.skipCount, maxResultCount: input.maxResultCount },
    },
    { apiName: this.apiName,...config });
  

  update = (id: string, input: CreateUpadteCorrespondanceDto, config?: Partial<Rest.Config>) =>
    this.restService.request<any, CorrespondanceDto>({
      method: 'PUT',
      url: `/api/app/correspondance/${id}`,
      body: input,
    },
    { apiName: this.apiName,...config });

  constructor(private restService: RestService) {}
}
