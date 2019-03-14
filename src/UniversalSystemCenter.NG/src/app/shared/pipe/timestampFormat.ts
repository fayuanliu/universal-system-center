import { Pipe, PipeTransform } from '@angular/core';
import * as format from 'date-fns/format';
/**
 * 将时间戳格式化
 */
@Pipe({ name: '_timestampFormat' })
export class TimestampFormatPipe implements PipeTransform {
    transform(value: number, formatString): string {
        if (formatString === void 0) { formatString = 'YYYY年MM月DD日 hh时mm分'; }
        if (value) {
            let date = new Date(value * 1000);
            return date.toLocaleString('chinese',{hour12:false})
            // return format(date, formatString);
        }
        else {
            return '';
        }
    }
}