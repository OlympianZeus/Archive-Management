import type { AuditedEntityDto } from '@abp/ng.core';
import type { Receptionist } from './receptionist.enum';
import type { Receiver } from './receiver.enum';
import type { Approver } from './approver.enum';
import type { Status } from './status.enum';

export interface CorrespondanceDto extends AuditedEntityDto<string> {
  sender?: string;
  cco: Receptionist;
  destinator: Receiver;
  branchName?: string;
  reference?: string;
  correspondanceApprover: Approver;
  correspondanceStatus: Status;
}

export interface CreateUpadteCorrespondanceDto {
  sender: string;
  cco: Receptionist;
  destinator: Receiver;
  branchName: string;
  reference: string;
  correspondanceApprover: Approver;
  correspondanceStatus: Status;
}
