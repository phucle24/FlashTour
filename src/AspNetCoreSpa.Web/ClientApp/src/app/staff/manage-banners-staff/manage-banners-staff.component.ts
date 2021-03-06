import {Component, HostBinding, Inject, OnInit, TemplateRef, ViewChild} from '@angular/core';
import {FieldTypes, IAppTableOptions, IOption} from "@app/models";
import {Validators} from "@angular/forms";
import {DataService, ModalService} from "@app/services";
import {ToastrService} from "@app/toastr";
import {AppTableComponent, FormsService} from "@app/shared";

@Component({
  selector: 'appc-manage-banners-staff',
  templateUrl: './manage-banners-staff.component.html',
  styleUrls: ['./manage-banners-staff.component.scss']
})
export class ManageBannersStaffComponent implements OnInit {
  @HostBinding('class')
  elementClass = 'col-lg-10 col-md-9 bg-light content';
  options: IAppTableOptions<Comunication>;
  postFieldOption:IOption[];
  @ViewChild('postTemplate', { static: true }) postTemplate: TemplateRef<any>;
  constructor(@Inject("BASE_URL") public baseUrl: string,
              private modalService: ModalService,
              private _dataService:DataService,
              private toastr: ToastrService,
              private formsService: FormsService,
  ) { }
  
  ngOnInit() {
    this.options={apiUrl:'api/banner'};
    var data = this._dataService.getFull<Post>(`${this.baseUrl}api/post`);
    let that = this;
    data.subscribe((result) => {
      console.log("Post: ",JSON.stringify(result.body));
      var fieldOptions=[];
      result.body.forEach((d, i) => {
        fieldOptions.push({
          key:d.id,
          value:d.name
        });
      });
      this.postFieldOption=fieldOptions;
      this.newBanner();
    });
  }
  newBanner(){
    this.options = {
      title: 'Banner',
      apiUrl: 'api/banner',
      disableFilter: true,
      disablechangetour: true,
      disableviewContact: true,
      disableFilterDepartue: true,
      disableFilterName: true,
      columns: [
        { prop: 'name', name: 'Name', fieldType: FieldTypes.Textbox, fieldValidations: [Validators.required, this.formsService.nameValidator] },
        { prop: 'description', name: 'Description', fieldType: FieldTypes.Textbox, fieldValidations: [Validators.required] },
        { prop: 'postId', name: 'Post Name', fieldType: FieldTypes.Select,
          fieldOptions: this.postFieldOption,cellTemplate: this.postTemplate},
        { prop: 'image', name: 'Image', fieldType: FieldTypes.FileUpload,fieldValidations: [Validators.required] },
      ]};
  }

}
