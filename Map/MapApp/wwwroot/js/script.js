const imageContainers = document.querySelectorAll('[data-state]');
const card = document.querySelector(".card");
const veri = [];
imageContainers.forEach((el) => veri.push(el));

imageContainers.forEach((imageContainer) => {
  imageContainer.addEventListener("mouseenter", () => {
    const id = event.target.id;
    const idElement = document.getElementById('id-element');

    idElement.innerHTML = `ID: ${id}`;
    card.style.display = "block";

  });

  imageContainer.addEventListener("mouseleave", () => {
    card.style.display = "none";
  });
});



function sendDataWithoutClick() {
   // Göndermek istediğiniz veri (ID örneği)
  var url = '/Map/_card/' + id; // URL'yi oluşturun
  // Şimdi bu URL üzerinden sunucuya veriyi gönderebilirsiniz
  // Bu işlem için AJAX veya fetch kullanabilirsiniz
  // Örnek bir AJAX isteği:
  $.ajax({
      url: url,
      type: 'GET',
      success: function (data) {
          // Sunucudan gelen verileri işleyin
      },
      error: function () {
          // Hata işleme kodu
      }
  });
}