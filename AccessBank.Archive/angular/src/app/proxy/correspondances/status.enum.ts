import { mapEnumToOptions } from '@abp/ng.core';

export enum Status {
  Pending = 0,
  Approved = 1,
  Declined = 2,
  Undefined = 3,
}

export const statusOptions = mapEnumToOptions(Status);
