Main = {

    init: function() {
        Main.openRemoteModal();
    },

    openRemoteModal: function () {
        $('.open-remote-modal').click(function(e) {
            e.preventDefault();
            var href = $(this).attr('href');
            var targetModal = "main-modal";
            if ($(this).hasOwnProperty('target-modal')) {
                var targetModal = $(this).attr('target-modal');
            }
            $.get(href, function(html) {
                $('#' + targetModal).find('.modal-content').first().html(html);
                $('#' + targetModal).modal('show');
            });
        })
    }
}

$('document').ready(function() {
    Main.init();
});