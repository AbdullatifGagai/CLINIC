$(document).ready(() => {
    
    
    const API_URL = $('#api-url').val();

    $('.file-input').fileinput({
        browseLabel: 'Browse',
        browseIcon: '<i class="icon-image2 position-left"></i>',
        removeIcon: '<i class="icon-cross3"></i>'
    });

    const jobId = $('#AllowID').val().trim();
    const jobNo = $('#unitcode').val().trim();
    let folderHash = $('#folder-hash').val().trim();
  
    if (folderHash === '#') {
        createFolder("AllowId-" + jobId);
        debugger;

    } else {
        getFiles();

        debugger;
    }

    $('.fileinput-upload-button').click(async function () {
        debugger;
        if (folderHash === '#') {
            ErrorAlert('Folder for this job hasn\'t been created yet');
            return;
        }

        const files = document.querySelector('input.file-input').files;

        if (files.length < 1) return;

        const payload = [];

        try {
            for (const file of files) {
                payload.push({
                    fileName: file.name,
                    fileType: file.type,
                    data: await convertToBase64(file)
                });
            }
        } catch (e) {
            console.error(e);
            ErrorAlert('Something went wrong while reading the file(s)');
            return;
        }

        $.LoadingOverlay('show');

        try {
            const response = await fetch(`${API_URL}?folderHash=${folderHash}`, {
                method: 'POST',
                headers: { 'Content-Type': 'text/plain' },
                body: JSON.stringify(payload)
            });

            if (response.status === 200) {
                SuccessAlert();

                const data = await response.json();

                let rows = '';

                for (const doc of data.message) {
                    rows += `
                        <tr>
                            <td>${doc.fileName}</td>
                            <td>
                                <a class="btn btn-xs btn-success" href="${doc.fileUrl}" target="_blank">View</a>
                            </td>
                        </tr>
                    `;
                }

                $('#documents-table tbody').append(rows);
            }
            else ErrorAlert('Something went wrong while uploading the file(s)')
        } catch (e) {
            console.error(e);
            ErrorAlert('Something went wrong while uploading the file(s)');
        } finally {
            $.LoadingOverlay('hide');
        }
    });

    function convertToBase64(file) {
        return new Promise((resolve, reject) => {
            const reader = new FileReader();
            reader.readAsDataURL(file);
            reader.onload = () => resolve(reader.result.replace(/^.*,/, ''));
            reader.onerror = error => reject(error);
        });
    }

    function createFolder(folderName) {

        debugger;
        GetJSONRequest(`${API_URL}?action=createFolder&folderName=${folderName}`, 'GET', null, data => {
            debugger;
            const model = {
                AllowID: jobId,
                DocumentPath: data.message
            };

            GetJSONRequest('/Transaction/Transaction_UnitAllow/DouPathSaveTransaction_UnitAllow', 'POST', model, response => {
                debugger;
                if (response !== 'OK')
                    ErrorAlert('Something went wrong while creating the unit allotment documents folder');
            });

            folderHash = data.message;


            debugger;
                

        });
    }

    function getFiles() {
        debugger;
        GetJSONRequest(`${API_URL}?action=getFiles&folderId=${folderHash}`, 'GET', null, data => {
            let rows = '';
            if (data.message) {
                for (const doc of data.message) {
                    rows += `
                    <tr>
                        <td>${doc.fileName}</td>
                        <td>
                            <a class="btn btn-xs btn-success" href="${doc.fileUrl}" target="_blank">View</a>
                        </td>
                    </tr>
                `;
                }

            }
            
            $('#documents-table tbody').html(rows);
        });
    }
});