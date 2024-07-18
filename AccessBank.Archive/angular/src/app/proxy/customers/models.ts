import type { AccountType } from './account-type.enum';
import type { AccountCategory } from './account-category.enum';
import type { AuditedEntityDto } from '@abp/ng.core';

export interface CreateUpdateCustomerDto {
  accountName: string;
  accountNumber: string;
  branchName: string;
  branchCode: number;
  type: AccountType;
  category: AccountCategory;
  onBoardDate: string;
  accountStatus: string;
}

export interface CustomerDto extends AuditedEntityDto<string> {
  accountName?: string;
  accountNumber?: string;
  branchName?: string;
  branchCode: number;
  type: AccountType;
  category: AccountCategory;
  onBoardDate?: string;
  accountStatus?: string;
}
