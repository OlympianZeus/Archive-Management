import { NgModule } from '@angular/core';
import { SharedModule } from '../shared/shared.module';

import { CorrespondanceRoutingModule } from './correspondance-routing.module';
import { CorrespondanceComponent } from './correspondance.component';


@NgModule({
  declarations: [CorrespondanceComponent
  ],
  imports: [
    SharedModule,
    CorrespondanceRoutingModule
  ]
})
export class CorrespondanceModule { }
