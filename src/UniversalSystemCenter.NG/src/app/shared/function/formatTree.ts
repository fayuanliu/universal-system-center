export const FormatTree = {
    formatTree:function(entity){
        let TreeList = [];
        entity.forEach(element => {
            let treeNode = {
                children: []
            };
            this.getTree(element, treeNode);
            TreeList.push(treeNode);
        });
        return TreeList;
    },
    getTree:function(element, treeNode){
        treeNode.isAllChecked = element.isAllChecked;
        treeNode.isChecked = element.isChecked;
        treeNode.isHalfChecked = element.isHalfChecked;
        treeNode.isDisableCheckbox = element.isDisableCheckbox;
        treeNode.isDisabled = element.isDisabled;
        treeNode.isExpanded = element.isExpanded;
        treeNode.isLeaf = element.isLeaf;
        treeNode.isSelectable = element.isSelectable;
        treeNode.isSelected = element.isSelected;
        treeNode.key = element.key;
        treeNode.level = element.level;
        treeNode.title = element.title;
        element.children.forEach(element1 => {
            let treeNode1 = {
                children: []
            };
            this.getTree(element1, treeNode1);
            treeNode.children.push(treeNode1);
        });
    }
}
