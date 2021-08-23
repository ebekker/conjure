// This is a JavaScript module that is loaded on demand. It can export any
// number of functions, and may import other JavaScript modules if required.

export function showPrompt(message) {
  return prompt(message, 'Type anything here');
}

export function getProperty(targ, prop) {
    return targ[prop];
}

export function setProperty(targ, prop, val) {
    targ[prop] = val;
}

export function downloadSaveAs(filename, content) {
    // Based on:
    //  https://wellsb.com/csharp/aspnet/blazor-jsinterop-save-file/
    var link = document.createElement('a');
    link.download = filename;
    link.href = "data:text/plain;charset=utf-8," + encodeURIComponent(content)
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
}

export function unloadEnable() {
    window.__conjure_unloadHandler = function (ev) {
        ev.preventDefault();
        ev.returnValue = "";
        return "";
    };
    window.addEventListener("beforeunload", window.__conjure_unloadHandler);
    console.log("beforeunload handler registered");
}

export function unloadDisable() {
    window.removeEventListener("beforeunload", window.__conjure_unloadHandler);
    window.__conjure_unloadHandler = null;
    console.log("beforeunload handler UNregistered");
}
