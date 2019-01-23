/// <reference path="jquery/jquery.d.ts" />
module UI {

    export class VideoImagePanel {
        public Initialize() {
            $(document).on("click", "[video-image-panel]", this.VideoImagePanel_Click.bind(this));
        }
        private VideoImagePanel_Click(e: JQueryEventObject) {
            var div = $(e.currentTarget);
            var url = div.attr("url");
            window.open(url);
        }
    }

    $(function () {
        var panel = new UI.VideoImagePanel();
        panel.Initialize();
    });
}