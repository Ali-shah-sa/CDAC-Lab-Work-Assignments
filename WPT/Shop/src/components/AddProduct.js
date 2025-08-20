import React, { useState } from 'react';

const AddProduct = ({ saveInfo }) => {
  const [productInfo, setProductInfo] = useState({
    productId: '',
    productName: '',
    price: '',
    Date: '',
  });

  const handleInputChange = (e) => {
    const { name, value } = e.target;
    setProductInfo({ ...productInfo, [name]: value });
  };

  const handleSubmit = () => {
    // Validation
    if (
      !productInfo.productId ||
      !productInfo.productName ||
      isNaN(productInfo.price) ||
      !productInfo.Date
    ) {
      alert('Please fill all fields correctly.');
      return;
    }

    // Save info
    saveInfo(productInfo);

    // Clear form fields
    setProductInfo({
      productId: '',
      productName: '',
      price: '',
      Date: '',
    });
  };

  return (
    <div className='border m-2 p-5'>
      <h2 className='text-center'>Add New Product</h2>
      <br></br>
      <form>
        <div className="form-group">
          <label htmlFor="productId">Product ID</label>
          <input
            type="text"
            className="form-control"
            id="productId"
            name="productId"
            value={productInfo.productId}
            onChange={handleInputChange}
            required
          />
        </div>
        <div className="form-group">
          <label htmlFor="productName">Product Name</label>
          <input
            type="text"
            className="form-control"
            id="productName"
            name="productName"
            value={productInfo.productName}
            onChange={handleInputChange}
            required
          />
        </div>
      
        <div className="form-group">
          <label htmlFor="price">Price</label>
          <input
            type="number"
            className="form-control"
            id="price"
            name="price"
            value={productInfo.price}
            onChange={handleInputChange}
            required
          />
        </div>
        <div className="form-group">
          <label htmlFor="Date">Expiry Date</label>
          <input
            type="date"
            className="form-control"
            id="Date"
            name="Date"
            value={productInfo.Date}
            onChange={handleInputChange}
            required
          />
        </div>
        <br></br>
        <button
          type="button"
          className="btn btn-success"
          onClick={handleSubmit}
        >
          Save Info
        </button>
      </form>
    </div>
  );
};

export default AddProduct;
