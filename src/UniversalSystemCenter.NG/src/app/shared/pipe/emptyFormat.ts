import { Pipe, PipeTransform } from '@angular/core';
/**
 * 格式化空值
 */
@Pipe({ name: '_emptyFormat' })
export class EmptyFormatPipe implements PipeTransform {
    transform(value: string, formatString): string {
        if (formatString === void 0) { formatString = '暂无'; }
        if (value) {
            return value;
        }
        else {
            return formatString;
        }
    }
}