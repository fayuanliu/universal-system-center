/**
 * 将对象赋值到模型（仅保留模型中的属性，仅支持第一层）
 * @param model 模型
 * @param obj 对象
 */
export function compareWith(model: any, obj: any): any {
  if (model && obj) {
    Object.keys(model).forEach(key => {
      model[key] = obj[key];
    });
  }
}
