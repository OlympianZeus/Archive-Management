import { mapEnumToOptions } from '@abp/ng.core';

export enum AccountCategory {
  Personal = 0,
  Corporate = 1,
}

export const accountCategoryOptions = mapEnumToOptions(AccountCategory);
