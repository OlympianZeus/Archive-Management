import { mapEnumToOptions } from '@abp/ng.core';

export enum Approver {
  Wilfried = 0,
  Eric = 1,
  Nicole = 2,
  Benie = 3,
  Undefined = 4,
}

export const approverOptions = mapEnumToOptions(Approver);
