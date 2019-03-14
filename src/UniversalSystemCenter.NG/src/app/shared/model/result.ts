export interface ResponseResult {
  result: number;
  data: any;
  code : number;
  message: string;
}

export class ResponsePage {
  page: number;
  pageSize: number;
  totalCount: number;
  pageCount: number;
  order: string;
  data: any[] = [];
}