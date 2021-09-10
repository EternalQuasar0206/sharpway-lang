class sharpway {
    //General Operations (Default)

    static handlePageIcon(icon) {
        let link = document.querySelector(`link[rel~='icon']`);
        if (!link) {
            link = document.createElement(`link`);
            link.rel = `icon`;
            document.getElementsByTagName(`head`)[0].appendChild(link);
        }
        link.href = icon;
        return link.href;
    }

    static handlePageVersion(ver) {
        if(ver){document.version = ver;} return document.version
    }

    static handlePageTitle(title) {
        if(title){document.title = title;} return document.title;
    }

    static pageDefine(object) {
        this.handlePageTitle(object.title);
        this.handlePageVersion(object.version);
        this.handlePageIcon(object.icon);
    }

    static domAppend(target, render) {
        document.querySelector(target).innerHTML += render;
    }

    //Date Time Operations

    static date = {
        now = () => Date.now(),
        parse = (dateString) => Date.parse(dateString),
        
    }

}