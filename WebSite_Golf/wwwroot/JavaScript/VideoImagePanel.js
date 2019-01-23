/// <reference path="jquery/jquery.d.ts" />
var UI;
(function (UI) {
    var VideoImagePanel = /** @class */ (function () {
        function VideoImagePanel() {
        }
        VideoImagePanel.prototype.Initialize = function () {
            $(document).on("click", "[video-image-panel]", this.VideoImagePanel_Click.bind(this));
        };
        VideoImagePanel.prototype.VideoImagePanel_Click = function (e) {
            var div = $(e.currentTarget);
            var url = div.attr("url");
            window.open(url);
        };
        return VideoImagePanel;
    }());
    UI.VideoImagePanel = VideoImagePanel;
    $(function () {
        var panel = new UI.VideoImagePanel();
        panel.Initialize();
    });
})(UI || (UI = {}));
//# sourceMappingURL=VideoImagePanel.js.map