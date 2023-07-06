document.addEventListener('DOMContentLoaded', function () {
  const menuItems = document.querySelectorAll('.menu-item');
  const contentItems = document.querySelectorAll('.content-item');

  menuItems.forEach(item => {
      item.addEventListener('click', function () {
          const dataContent = item.getAttribute('data-content');
          contentItems.forEach(contentItem => {
              contentItem.style.display = 'none';
          });
          const selectedContent = document.getElementById(dataContent);
          if (selectedContent) {
              selectedContent.style.display = 'block';
          }
      });
  });
});
