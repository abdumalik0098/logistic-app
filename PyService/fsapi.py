from fastapi import FastAPI, Body, Response, status
from fastapi.responses import JSONResponse
from fastapi.encoders import jsonable_encoder
import main
 
app = FastAPI()

@app.get("/api/autos")
def root():
    data = main.exl_data()
    # json_data = jsonable_encoder(data)
    return Response(content=data, media_type="application/json")

# @app.post("/api/enxor")
# def create_enc(data = Body()):
#     text = data["text"]
#     result = encoder.encryptDecrypt(text)
#     resp = {"encode": result}
#     json_data = jsonable_encoder(resp)
#     return JSONResponse(content=json_data)

 