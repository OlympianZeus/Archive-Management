import { mapEnumToOptions } from '@abp/ng.core';

export enum AccountType {
  Current = 0,
  Salary = 1,
  Saving = 2,
}

export const accountTypeOptions = mapEnumToOptions(AccountType);
