import React, { useState } from 'react';
import Nav from './components/Nav';
import 'bootstrap/dist/css/bootstrap.min.css';
import AddProduct from './components/AddProduct';
import ProductList from './components/ProductList';

function App() {
  const [productArray, setProductArray] = useState([]);

  const saveInfo = (productInfo) => {
    setProductArray([...productArray, productInfo]);
  };

  const handleDelete = (index) => {
    const updatedProduct = [...productArray];
    updatedProduct.splice(index, 1);
    setProductArray(updatedProduct);
  };

  return (
    <div>
      <Nav />

      <div className="container mt-4">
        <div className="row">
          <div className="col-md-6">
            <AddProduct saveInfo={saveInfo} />
          </div>
          <div className="col-md-6">
            <ProductList productArray={productArray} handleDelete={handleDelete} />
          </div>
        </div>
      </div>
    </div>
  );
}

export default App;
