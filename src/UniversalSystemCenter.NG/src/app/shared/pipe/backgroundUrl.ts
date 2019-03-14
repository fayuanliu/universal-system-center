import { Pipe, PipeTransform } from "@angular/core";
import { environment } from "@env/environment";

@Pipe({ name: '_backgroundUrl' })
export class BackgroundUrlPipe implements PipeTransform {
    transform(url: string): string {
        if (url == '' || url == 'null' || url == null || url == undefined) {
            return 'none';
        }

        if (url.indexOf('http://') > -1 || url.indexOf('https://') > -1) {
            return `url(${url})`;
        }
        return `url(${environment.FIlE_URL + url})`;
    }
}
