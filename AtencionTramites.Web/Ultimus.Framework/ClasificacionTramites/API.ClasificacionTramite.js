﻿jQuery(document).ready(function () {
    UpdateControlsSettings("FILTRO_FRM_BotonesAT", "BotonesAT", "frmBotones", function () {
       getDataModel();
    });
})
/*
FILTRO_FRM_AnexosRadicadoAT	        FILTRO_FRM_AnexosRadicadoAT	 
FILTRO_FRM_BotonesAT	            FILTRO_FRM_BotonesAT	 
FILTRO_FRM_ClasificacionPeticionAT	FILTRO_FRM_ClasificacionPeticionAT	 
FILTRO_FRM_DecisionAT	|           FILTRO_FRM_DecisionAT	 
FILTRO_FRM_InfoRadicadoAT	        FILTRO_FRM_InfoRadicadoAT	 
FILTRO_FRM_PeticionarioEnfoqueAT	FILTRO_FRM_PeticionarioEnfoqueAT	 
FILTRO_FRM_PeticionariosAT	        FILTRO_FRM_PeticionariosAT	 
FILTRO_FRM_PeticionarioTablaAT	    FILTRO_FRM_PeticionarioTablaAT
*/

this.getDataModel = function () {
    ENDREQUEST();
}