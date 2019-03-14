import { Pipe, PipeTransform } from "@angular/core";
import { environment } from "@env/environment";

@Pipe({ name: '_urlFormat' })
export class FormatUrlPipe implements PipeTransform {
    transform(url: string): string {
        if (url) {
            if (url.indexOf('http://') > -1 || url.indexOf('https://') > -1) {
                return url
            }
            return environment.FIlE_URL + url;
        }
        return '';
    }
}
