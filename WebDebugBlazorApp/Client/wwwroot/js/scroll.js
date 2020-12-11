
    window.convertArray = (win1251Array) => {
    var win1251decoder = new TextDecoder('windows-1251');
    var bytes = new Uint8Array(win1251Array);
    var decodedArray = win1251decoder.decode(bytes);
    console.log(decodedArray);
    return decodedArray;
};
var i = 1;
window.scrollToBottom = () => {
    var obj = document.getElementById("textarea");
    //obj.value += i + "\n";
    //i++;
    obj.scrollTop = obj.scrollHeight; // good
};

window.writeStrToControl = (str, controlName) => {
    var obj = document.getElementById(controlName);
    //obj.value += i + "\n";
    //i++;
    obj.value = str;
    obj.scrollTop = obj.scrollHeight; // good
};
