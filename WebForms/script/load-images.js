fetch('config/config.json')
    .then(response => response.json())
    .then(data => {
        const imageConfig = data.images;

        document.querySelectorAll('img[data-image-id]').forEach(img => {
            const imageId = img.getAttribute('data-image-id');
            const config = imageConfig.find(item => item.id === imageId);

            if (config) {
                if (config.title != null) {
                    img.title = config.title;
                }

                if (config.alt != null) {
                    img.alt = config.alt;
                }

                if (config.src != null) {
                    img.src = config.src;
                }

                if (config.width != null) {
                    img.width = config.width;
                }

                if (config.height != null) {
                    img.height = config.height;
                }

                if (config.class != null) {
                    img.className = config.class;
                }
            }
        }
        );
    }
    )
    .catch(error => console.error('Error loading config.json:', error));