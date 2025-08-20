//for(var i=0;i<1000;i++){
//    db.clientes.insert({nome:"cliente"+i , age: i })
//    
//}
db.getCollection('clientes').find({})