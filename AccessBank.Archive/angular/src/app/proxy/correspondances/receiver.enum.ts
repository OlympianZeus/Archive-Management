import { mapEnumToOptions } from '@abp/ng.core';

export enum Receiver {
  Patrick = 0,
  Grace = 1,
  Peter = 2,
  Benjamin = 3,
  Undefined = 4,
}

export const receiverOptions = mapEnumToOptions(Receiver);
