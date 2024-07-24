import { mapEnumToOptions } from '@abp/ng.core';

export enum Receptionist {
  Joel = 0,
  Martine = 1,
  Marc = 2,
  Undefined = 3,
}

export const receptionistOptions = mapEnumToOptions(Receptionist);
